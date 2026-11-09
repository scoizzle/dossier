# Fact 5aabf944

Store id: 0378fe86-cb8c-49f7-aa6a-1f5da5132757

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
- posted_at: `2026-11-09T23:44:50.1245080+00:00`

## Data

```json
{
  "end_line": 1923,
  "entity_kind": "method",
  "parent": "DecimalField",
  "start_line": 1921,
  "symbol": "DecimalField.get_prep_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1921,"selector":"L1921-L1923","symbol":"DecimalField.get_prep_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DecimalField.get_prep_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1923,
    "entity_kind": "method",
    "parent": "DecimalField",
    "start_line": 1921,
    "symbol": "DecimalField.get_prep_value"
  },
  "id": "0378fe86-cb8c-49f7-aa6a-1f5da5132757",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1245080+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1921,
        "selector": "L1921-L1923",
        "symbol": "DecimalField.get_prep_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "3b3afd2f-13df-432d-bf1e-b99d366aab5e",
  "subject_name": "django/db/models/fields/__init__::DecimalField.get_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_value(self, value)"
}
```
