# Fact 49d8600f

Store id: 5e32b44e-2d09-4dce-9877-8beb59eb090c

## Text

```text
def get_prep_value(self, value)
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
- posted_at: `2026-11-09T23:31:56.6984630+00:00`

## Data

```json
{
  "end_line": 2211,
  "entity_kind": "method",
  "parent": "IntegerField",
  "start_line": 2202,
  "symbol": "IntegerField.get_prep_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2202,"selector":"L2202-L2211","symbol":"IntegerField.get_prep_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::IntegerField.get_prep_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2211,
    "entity_kind": "method",
    "parent": "IntegerField",
    "start_line": 2202,
    "symbol": "IntegerField.get_prep_value"
  },
  "id": "5e32b44e-2d09-4dce-9877-8beb59eb090c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.6984630+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2202,
        "selector": "L2202-L2211",
        "symbol": "IntegerField.get_prep_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "d35d3ccb-81f6-4e98-b5a4-899eb6f3ff7d",
  "subject_name": "django/db/models/fields/__init__::IntegerField.get_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_value(self, value)"
}
```
