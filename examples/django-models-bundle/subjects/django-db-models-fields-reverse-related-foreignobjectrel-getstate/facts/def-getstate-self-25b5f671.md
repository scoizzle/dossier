# Fact 25b5f671

Store id: 38148fa5-a2d2-426a-aa9d-786fd623c05d

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
- posted_at: `2026-11-09T23:44:52.4792730+00:00`

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
  "id": "38148fa5-a2d2-426a-aa9d-786fd623c05d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.4792730+00:00"
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
  "subject_id": "3b401e7d-3622-4ee3-a1c1-7b5147824af5",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.__getstate__",
  "tags": [
    "entity:method"
  ],
  "text": "def __getstate__(self)"
}
```
