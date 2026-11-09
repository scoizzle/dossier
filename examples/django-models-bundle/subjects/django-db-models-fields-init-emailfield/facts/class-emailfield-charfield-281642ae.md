# Fact 281642ae

Store id: ce90ebdb-a0bc-48f4-9f8a-465f313e39f8

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
- posted_at: `2026-11-09T23:31:56.6599300+00:00`

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
  "id": "ce90ebdb-a0bc-48f4-9f8a-465f313e39f8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.6599300+00:00"
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
  "subject_id": "86349baa-9006-4bc7-8a4c-82406d3e39eb",
  "subject_name": "django/db/models/fields/__init__::EmailField",
  "tags": [
    "entity:class"
  ],
  "text": "class EmailField(CharField)"
}
```
