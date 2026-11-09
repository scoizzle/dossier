# Fact 1adfb87b

Store id: ae334b1a-8250-4e20-bd27-6224aebb72ac

## Text

```text
def _check_default(self)
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
- posted_at: `2026-11-09T23:31:58.2369120+00:00`

## Data

```json
{
  "end_line": 60,
  "entity_kind": "method",
  "parent": "CheckFieldDefaultMixin",
  "start_line": 40,
  "symbol": "CheckFieldDefaultMixin._check_default"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/mixins.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":40,"selector":"L40-L60","symbol":"CheckFieldDefaultMixin._check_default"}`

## Referenced by

None.

## Subject

[django/db/models/fields/mixins::CheckFieldDefaultMixin._check_default](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 60,
    "entity_kind": "method",
    "parent": "CheckFieldDefaultMixin",
    "start_line": 40,
    "symbol": "CheckFieldDefaultMixin._check_default"
  },
  "id": "ae334b1a-8250-4e20-bd27-6224aebb72ac",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.2369120+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 40,
        "selector": "L40-L60",
        "symbol": "CheckFieldDefaultMixin._check_default"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/mixins.py"
    }
  ],
  "status": "live",
  "subject_id": "86bf9517-5827-4537-a35a-ae9f93cfcefd",
  "subject_name": "django/db/models/fields/mixins::CheckFieldDefaultMixin._check_default",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_default(self)"
}
```
