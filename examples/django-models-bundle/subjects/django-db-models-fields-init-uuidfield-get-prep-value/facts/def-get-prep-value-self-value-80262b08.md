# Fact 80262b08

Store id: 4928c7f9-bcf0-4dcc-b2c2-76401d5d9bb5

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
- posted_at: `2026-11-09T23:44:50.3040560+00:00`

## Data

```json
{
  "end_line": 2840,
  "entity_kind": "method",
  "parent": "UUIDField",
  "start_line": 2838,
  "symbol": "UUIDField.get_prep_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2838,"selector":"L2838-L2840","symbol":"UUIDField.get_prep_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::UUIDField.get_prep_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2840,
    "entity_kind": "method",
    "parent": "UUIDField",
    "start_line": 2838,
    "symbol": "UUIDField.get_prep_value"
  },
  "id": "4928c7f9-bcf0-4dcc-b2c2-76401d5d9bb5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.3040560+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2838,
        "selector": "L2838-L2840",
        "symbol": "UUIDField.get_prep_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "434db47e-e6c0-4ba0-b4ef-0f66a09a057c",
  "subject_name": "django/db/models/fields/__init__::UUIDField.get_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_value(self, value)"
}
```
