# Fact cbdbb90d

Store id: 80333a49-64be-48af-ad3b-402fcf17ed38

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
- posted_at: `2026-11-09T22:39:42.4723240+00:00`

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
  "id": "80333a49-64be-48af-ad3b-402fcf17ed38",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.4723240+00:00"
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
  "subject_id": "d21e2ce7-1fee-4eac-bacb-cb328bf3444b",
  "subject_name": "django/db/models/fields/__init__::DurationField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
