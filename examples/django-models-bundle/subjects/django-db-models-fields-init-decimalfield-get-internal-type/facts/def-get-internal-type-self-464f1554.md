# Fact 464f1554

Store id: 85ef886e-0375-45fd-a090-d95c06167548

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
- posted_at: `2026-11-09T23:44:50.1209600+00:00`

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
  "id": "85ef886e-0375-45fd-a090-d95c06167548",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1209600+00:00"
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
  "subject_id": "6b8b81ba-18a5-4695-9f73-d18fd9d2d88e",
  "subject_name": "django/db/models/fields/__init__::DecimalField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
