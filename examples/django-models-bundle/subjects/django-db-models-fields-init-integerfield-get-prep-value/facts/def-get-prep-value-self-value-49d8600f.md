# Fact 49d8600f

Store id: e6bcc528-7574-45c9-bf4d-0de789b97915

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
- posted_at: `2026-11-09T23:44:50.1634610+00:00`

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
  "id": "e6bcc528-7574-45c9-bf4d-0de789b97915",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1634610+00:00"
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
  "subject_id": "a889d280-d5fd-4d75-b456-3eb4d13be739",
  "subject_name": "django/db/models/fields/__init__::IntegerField.get_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_value(self, value)"
}
```
