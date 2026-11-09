# Fact 801c4bed

Store id: 977da0e5-d935-4f71-b92d-00e737a39636

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
- posted_at: `2026-11-09T23:44:48.5429610+00:00`

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
  "id": "977da0e5-d935-4f71-b92d-00e737a39636",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5429610+00:00"
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
  "subject_id": "5ade7121-b732-4e42-97eb-e0ca7a427226",
  "subject_name": "django/db/models/base::Model.date_error_message",
  "tags": [
    "entity:method"
  ],
  "text": "def date_error_message(self, lookup_type, field_name, unique_for)"
}
```
