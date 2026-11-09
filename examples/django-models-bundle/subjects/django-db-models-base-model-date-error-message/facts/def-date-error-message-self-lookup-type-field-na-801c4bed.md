# Fact 801c4bed

Store id: 9cbea9ec-8920-4304-8714-d9c80ddabae5

## Text

```text
def date_error_message(self, lookup_type, field_name, unique_for)
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
- posted_at: `2026-11-09T22:39:40.3505910+00:00`

## Data

```json
{
  "end_line": 1639,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 1624,
  "symbol": "Model.date_error_message"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1624,"selector":"L1624-L1639","symbol":"Model.date_error_message"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model.date_error_message](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1639,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 1624,
    "symbol": "Model.date_error_message"
  },
  "id": "9cbea9ec-8920-4304-8714-d9c80ddabae5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3505910+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1624,
        "selector": "L1624-L1639",
        "symbol": "Model.date_error_message"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "865de93b-9024-4f3c-92e4-c58dc28328ab",
  "subject_name": "django/db/models/base::Model.date_error_message",
  "tags": [
    "entity:method"
  ],
  "text": "def date_error_message(self, lookup_type, field_name, unique_for)"
}
```
