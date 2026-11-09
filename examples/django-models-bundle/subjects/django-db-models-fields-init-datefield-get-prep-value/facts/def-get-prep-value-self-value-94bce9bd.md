# Fact 94bce9bd

Store id: 2904cd9e-3e3e-4f7e-80b1-2d4e6217fd7a

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
- posted_at: `2026-11-09T23:31:56.5861390+00:00`

## Data

```json
{
  "end_line": 1578,
  "entity_kind": "method",
  "parent": "DateField",
  "start_line": 1576,
  "symbol": "DateField.get_prep_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1576,"selector":"L1576-L1578","symbol":"DateField.get_prep_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DateField.get_prep_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1578,
    "entity_kind": "method",
    "parent": "DateField",
    "start_line": 1576,
    "symbol": "DateField.get_prep_value"
  },
  "id": "2904cd9e-3e3e-4f7e-80b1-2d4e6217fd7a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.5861390+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1576,
        "selector": "L1576-L1578",
        "symbol": "DateField.get_prep_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "b1ad11f7-492d-4978-a77a-4b2090e855a8",
  "subject_name": "django/db/models/fields/__init__::DateField.get_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_value(self, value)"
}
```
