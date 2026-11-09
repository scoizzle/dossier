# Fact 281642ae

Store id: fe04e6dc-5b1f-4e60-8e80-7fe9a6cbe34a

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
- posted_at: `2026-11-09T22:39:42.4870220+00:00`

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
  "id": "fe04e6dc-5b1f-4e60-8e80-7fe9a6cbe34a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.4870220+00:00"
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
  "subject_id": "6fe67d0d-d0f5-4a93-9afb-61ac3bbf6dd2",
  "subject_name": "django/db/models/fields/__init__::EmailField",
  "tags": [
    "entity:class"
  ],
  "text": "class EmailField(CharField)"
}
```
