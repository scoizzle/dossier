# Fact 9853f2bb

Store id: 5fc5c8ee-a006-4ad1-900b-f334d859d5e4

## Text

```text
def check(self, **kwargs)
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
- posted_at: `2026-11-09T23:44:50.9346130+00:00`

## Data

```json
{
  "end_line": 52,
  "entity_kind": "method",
  "parent": "JSONField",
  "start_line": 48,
  "symbol": "JSONField.check"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":48,"selector":"L48-L52","symbol":"JSONField.check"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::JSONField.check](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 52,
    "entity_kind": "method",
    "parent": "JSONField",
    "start_line": 48,
    "symbol": "JSONField.check"
  },
  "id": "5fc5c8ee-a006-4ad1-900b-f334d859d5e4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.9346130+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 48,
        "selector": "L48-L52",
        "symbol": "JSONField.check"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "9363cecd-757f-47cc-827f-a4d24a0ebccb",
  "subject_name": "django/db/models/fields/json::JSONField.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, **kwargs)"
}
```
