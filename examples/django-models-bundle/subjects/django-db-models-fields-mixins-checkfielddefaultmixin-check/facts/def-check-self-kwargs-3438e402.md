# Fact 3438e402

Store id: 22fc8387-cfda-4ff3-8ac7-bbb607df389a

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
- posted_at: `2026-11-09T22:39:43.9433920+00:00`

## Data

```json
{
  "end_line": 65,
  "entity_kind": "method",
  "parent": "CheckFieldDefaultMixin",
  "start_line": 62,
  "symbol": "CheckFieldDefaultMixin.check"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/mixins.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":62,"selector":"L62-L65","symbol":"CheckFieldDefaultMixin.check"}`

## Referenced by

None.

## Subject

[django/db/models/fields/mixins::CheckFieldDefaultMixin.check](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 65,
    "entity_kind": "method",
    "parent": "CheckFieldDefaultMixin",
    "start_line": 62,
    "symbol": "CheckFieldDefaultMixin.check"
  },
  "id": "22fc8387-cfda-4ff3-8ac7-bbb607df389a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.9433920+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 62,
        "selector": "L62-L65",
        "symbol": "CheckFieldDefaultMixin.check"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/mixins.py"
    }
  ],
  "status": "live",
  "subject_id": "12cc5227-9868-4267-a382-2599a5066b0a",
  "subject_name": "django/db/models/fields/mixins::CheckFieldDefaultMixin.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, **kwargs)"
}
```
