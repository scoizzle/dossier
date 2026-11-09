# Fact 801c4bed

Store id: 585b8c24-08c4-4ac8-9768-09943a091d71

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
- posted_at: `2026-11-09T23:31:53.7568640+00:00`

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
  "id": "585b8c24-08c4-4ac8-9768-09943a091d71",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7568640+00:00"
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
  "subject_id": "29f2e0a8-7455-429e-9aa0-56fc5a99d9d6",
  "subject_name": "django/db/models/base::Model.date_error_message",
  "tags": [
    "entity:method"
  ],
  "text": "def date_error_message(self, lookup_type, field_name, unique_for)"
}
```
