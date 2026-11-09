# Fact 3ac9ffde

Store id: 0a37a959-7150-4630-990a-2a13e6dfd260

## Text

```text
def rel_db_type(self, connection)
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
- posted_at: `2026-11-09T22:39:42.7642210+00:00`

## Data

```json
{
  "end_line": 2976,
  "entity_kind": "method",
  "parent": "BigAutoField",
  "start_line": 2975,
  "symbol": "BigAutoField.rel_db_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2975,"selector":"L2975-L2976","symbol":"BigAutoField.rel_db_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::BigAutoField.rel_db_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2976,
    "entity_kind": "method",
    "parent": "BigAutoField",
    "start_line": 2975,
    "symbol": "BigAutoField.rel_db_type"
  },
  "id": "0a37a959-7150-4630-990a-2a13e6dfd260",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.7642210+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2975,
        "selector": "L2975-L2976",
        "symbol": "BigAutoField.rel_db_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "d45168c3-bc5d-4391-ad41-03ec04e6643f",
  "subject_name": "django/db/models/fields/__init__::BigAutoField.rel_db_type",
  "tags": [
    "entity:method"
  ],
  "text": "def rel_db_type(self, connection)"
}
```
