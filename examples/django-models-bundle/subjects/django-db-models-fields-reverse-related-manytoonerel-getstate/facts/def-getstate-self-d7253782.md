# Fact d7253782

Store id: e1a3942a-f901-4aad-b9bc-959d50bef1f1

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
- posted_at: `2026-11-09T22:39:45.3714560+00:00`

## Data

```json
{
  "end_line": 292,
  "entity_kind": "method",
  "parent": "ManyToOneRel",
  "start_line": 289,
  "symbol": "ManyToOneRel.__getstate__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":289,"selector":"L289-L292","symbol":"ManyToOneRel.__getstate__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ManyToOneRel.__getstate__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 292,
    "entity_kind": "method",
    "parent": "ManyToOneRel",
    "start_line": 289,
    "symbol": "ManyToOneRel.__getstate__"
  },
  "id": "e1a3942a-f901-4aad-b9bc-959d50bef1f1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.3714560+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 289,
        "selector": "L289-L292",
        "symbol": "ManyToOneRel.__getstate__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "d33b9654-f452-4a31-81ea-fae45e5d8737",
  "subject_name": "django/db/models/fields/reverse_related::ManyToOneRel.__getstate__",
  "tags": [
    "entity:method"
  ],
  "text": "def __getstate__(self)"
}
```
