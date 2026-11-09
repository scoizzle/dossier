# Fact 99fe1645

Store id: 8777b406-107a-471d-aad9-d196539fee8a

## Text

```text
def run_validators(self, value)
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
- posted_at: `2026-11-09T23:44:50.0074120+00:00`

## Data

```json
{
  "end_line": 836,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 822,
  "symbol": "Field.run_validators"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":822,"selector":"L822-L836","symbol":"Field.run_validators"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.run_validators](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 836,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 822,
    "symbol": "Field.run_validators"
  },
  "id": "8777b406-107a-471d-aad9-d196539fee8a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.0074120+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 822,
        "selector": "L822-L836",
        "symbol": "Field.run_validators"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "4781070a-27ed-49f0-b2e2-2d7283092ae4",
  "subject_name": "django/db/models/fields/__init__::Field.run_validators",
  "tags": [
    "entity:method"
  ],
  "text": "def run_validators(self, value)"
}
```
