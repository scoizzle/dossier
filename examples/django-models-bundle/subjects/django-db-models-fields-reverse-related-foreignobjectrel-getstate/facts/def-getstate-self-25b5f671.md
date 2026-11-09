# Fact 25b5f671

Store id: a5678fa1-1f05-46f5-994a-9045816f46c4

## Text

```text
def __getstate__(self)
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
- posted_at: `2026-11-09T22:39:45.3421560+00:00`

## Data

```json
{
  "end_line": 170,
  "entity_kind": "method",
  "parent": "ForeignObjectRel",
  "start_line": 160,
  "symbol": "ForeignObjectRel.__getstate__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":160,"selector":"L160-L170","symbol":"ForeignObjectRel.__getstate__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ForeignObjectRel.__getstate__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 170,
    "entity_kind": "method",
    "parent": "ForeignObjectRel",
    "start_line": 160,
    "symbol": "ForeignObjectRel.__getstate__"
  },
  "id": "a5678fa1-1f05-46f5-994a-9045816f46c4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.3421560+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 160,
        "selector": "L160-L170",
        "symbol": "ForeignObjectRel.__getstate__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "9a00d0bf-6c06-4db9-a105-93b69e1fd46d",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.__getstate__",
  "tags": [
    "entity:method"
  ],
  "text": "def __getstate__(self)"
}
```
