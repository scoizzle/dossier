# Fact 00f09d0d

Store id: e0400308-4aaf-4ee6-8527-9fd1c6e9f365

## Text

```text
def get_deferred_fields(self)
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
- posted_at: `2026-11-09T23:44:48.5311730+00:00`

## Data

```json
{
  "end_line": 733,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 725,
  "symbol": "Model.get_deferred_fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":725,"selector":"L725-L733","symbol":"Model.get_deferred_fields"}`

## Items

```json
[
  {
    "text": "Return a set containing names of deferred fields for this instance.",
    "locator": {
      "line": 726
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/base::Model.get_deferred_fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 733,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 725,
    "symbol": "Model.get_deferred_fields"
  },
  "id": "e0400308-4aaf-4ee6-8527-9fd1c6e9f365",
  "items": [
    {
      "locator": {
        "line": 726
      },
      "text": "Return a set containing names of deferred fields for this instance."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5311730+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 725,
        "selector": "L725-L733",
        "symbol": "Model.get_deferred_fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "5a49faae-fd55-4e75-ad7e-f792d664dee1",
  "subject_name": "django/db/models/base::Model.get_deferred_fields",
  "tags": [
    "entity:method"
  ],
  "text": "def get_deferred_fields(self)"
}
```
