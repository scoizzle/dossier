# Fact 1352a834

Store id: 926ac9b6-381a-4b7d-b59d-f2ba710ff12d

## Text

```text
def get_internal_type(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:56.5099990+00:00`

## Data

```json
{
  "end_line": 1024,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 1023,
  "symbol": "Field.get_internal_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1023,"selector":"L1023-L1024","symbol":"Field.get_internal_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.get_internal_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1024,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 1023,
    "symbol": "Field.get_internal_type"
  },
  "id": "926ac9b6-381a-4b7d-b59d-f2ba710ff12d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.5099990+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1023,
        "selector": "L1023-L1024",
        "symbol": "Field.get_internal_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "1b6b1031-bcd4-426a-9ee5-e7776319ff29",
  "subject_name": "django/db/models/fields/__init__::Field.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
