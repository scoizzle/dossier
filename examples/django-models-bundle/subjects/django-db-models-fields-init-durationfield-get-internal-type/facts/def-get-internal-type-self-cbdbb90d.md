# Fact cbdbb90d

Store id: 12aca0cc-1114-4d95-be0e-e97499cd38ff

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
- posted_at: `2026-11-09T23:31:56.6465770+00:00`

## Data

```json
{
  "end_line": 1954,
  "entity_kind": "method",
  "parent": "DurationField",
  "start_line": 1953,
  "symbol": "DurationField.get_internal_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1953,"selector":"L1953-L1954","symbol":"DurationField.get_internal_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DurationField.get_internal_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1954,
    "entity_kind": "method",
    "parent": "DurationField",
    "start_line": 1953,
    "symbol": "DurationField.get_internal_type"
  },
  "id": "12aca0cc-1114-4d95-be0e-e97499cd38ff",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.6465770+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1953,
        "selector": "L1953-L1954",
        "symbol": "DurationField.get_internal_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "22136bba-e7be-4adf-9c1e-6c9d962f60a3",
  "subject_name": "django/db/models/fields/__init__::DurationField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
