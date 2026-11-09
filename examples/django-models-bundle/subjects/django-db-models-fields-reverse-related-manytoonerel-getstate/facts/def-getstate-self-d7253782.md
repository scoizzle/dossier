# Fact d7253782

Store id: 8666354f-a842-4342-8dab-240d675f610a

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
- posted_at: `2026-11-09T23:44:52.5101710+00:00`

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
  "id": "8666354f-a842-4342-8dab-240d675f610a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.5101710+00:00"
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
  "subject_id": "8e04ef72-cb06-4910-9df6-783b9889a4aa",
  "subject_name": "django/db/models/fields/reverse_related::ManyToOneRel.__getstate__",
  "tags": [
    "entity:method"
  ],
  "text": "def __getstate__(self)"
}
```
