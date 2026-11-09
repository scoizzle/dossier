# Fact 464f1554

Store id: ef1c8ed5-c1ac-4191-bf21-2b5bfaf740e5

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
- posted_at: `2026-11-09T23:31:56.6363570+00:00`

## Data

```json
{
  "end_line": 1891,
  "entity_kind": "method",
  "parent": "DecimalField",
  "start_line": 1890,
  "symbol": "DecimalField.get_internal_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1890,"selector":"L1890-L1891","symbol":"DecimalField.get_internal_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DecimalField.get_internal_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1891,
    "entity_kind": "method",
    "parent": "DecimalField",
    "start_line": 1890,
    "symbol": "DecimalField.get_internal_type"
  },
  "id": "ef1c8ed5-c1ac-4191-bf21-2b5bfaf740e5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.6363570+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1890,
        "selector": "L1890-L1891",
        "symbol": "DecimalField.get_internal_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "9968186e-5dd9-49d2-8649-05a021ad007c",
  "subject_name": "django/db/models/fields/__init__::DecimalField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
