# Fact 5aabf944

Store id: e40a2fee-1c42-410b-976f-0bca6df65e97

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
- posted_at: `2026-11-09T23:31:56.6417500+00:00`

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
  "id": "e40a2fee-1c42-410b-976f-0bca6df65e97",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.6417500+00:00"
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
  "subject_id": "381019a3-1837-43c3-b5e1-d9576db33ef7",
  "subject_name": "django/db/models/fields/__init__::DecimalField.get_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_value(self, value)"
}
```
