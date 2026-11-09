# Fact 08ee3db8

Store id: 2f4a709d-08bd-45ee-bd05-e83adc5f5d4a

## Text

```text
def validators(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:50.1171630+00:00`

## Data

```json
{
  "end_line": 1876,
  "entity_kind": "method",
  "parent": "DecimalField",
  "start_line": 1871,
  "symbol": "DecimalField.validators"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1871,"selector":"L1871-L1876","symbol":"DecimalField.validators"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DecimalField.validators](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1876,
    "entity_kind": "method",
    "parent": "DecimalField",
    "start_line": 1871,
    "symbol": "DecimalField.validators"
  },
  "id": "2f4a709d-08bd-45ee-bd05-e83adc5f5d4a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1171630+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1871,
        "selector": "L1871-L1876",
        "symbol": "DecimalField.validators"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "c74e906b-9575-4c0a-a69a-4fc90e4a9eef",
  "subject_name": "django/db/models/fields/__init__::DecimalField.validators",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def validators(self)"
}
```
