# Fact 1cc37b19

Store id: b2c18de9-921a-43b7-86ac-f537427b0238

## Text

```text
class IntegerField(Field)
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
- posted_at: `2026-11-09T23:31:56.6920770+00:00`

## Data

```json
{
  "end_line": 2238,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 2141,
  "symbol": "IntegerField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2141,"selector":"L2141-L2238","symbol":"IntegerField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::IntegerField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2238,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 2141,
    "symbol": "IntegerField"
  },
  "id": "b2c18de9-921a-43b7-86ac-f537427b0238",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.6920770+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2141,
        "selector": "L2141-L2238",
        "symbol": "IntegerField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "09f77384-ab80-4f82-8675-c8ccff7e38d1",
  "subject_name": "django/db/models/fields/__init__::IntegerField",
  "tags": [
    "entity:class"
  ],
  "text": "class IntegerField(Field)"
}
```
