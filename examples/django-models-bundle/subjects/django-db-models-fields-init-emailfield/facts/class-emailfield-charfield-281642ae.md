# Fact 281642ae

Store id: 1eb9477d-2368-4d6a-9dbd-7f51b13b5436

## Text

```text
class EmailField(CharField)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:50.1373810+00:00`

## Data

```json
{
  "end_line": 2020,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 1997,
  "symbol": "EmailField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1997,"selector":"L1997-L2020","symbol":"EmailField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::EmailField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2020,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 1997,
    "symbol": "EmailField"
  },
  "id": "1eb9477d-2368-4d6a-9dbd-7f51b13b5436",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1373810+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1997,
        "selector": "L1997-L2020",
        "symbol": "EmailField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "f5122cf5-0e4c-47bb-8eae-b2ef65cc2360",
  "subject_name": "django/db/models/fields/__init__::EmailField",
  "tags": [
    "entity:class"
  ],
  "text": "class EmailField(CharField)"
}
```
