# Fact 5a23ae6b

Store id: 7007fabe-2d02-429f-a886-8a300734804f

## Text

```text
def __hash__(self)
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
- posted_at: `2026-11-09T22:39:45.3389360+00:00`

## Data

```json
{
  "end_line": 158,
  "entity_kind": "method",
  "parent": "ForeignObjectRel",
  "start_line": 157,
  "symbol": "ForeignObjectRel.__hash__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":157,"selector":"L157-L158","symbol":"ForeignObjectRel.__hash__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ForeignObjectRel.__hash__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 158,
    "entity_kind": "method",
    "parent": "ForeignObjectRel",
    "start_line": 157,
    "symbol": "ForeignObjectRel.__hash__"
  },
  "id": "7007fabe-2d02-429f-a886-8a300734804f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.3389360+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 157,
        "selector": "L157-L158",
        "symbol": "ForeignObjectRel.__hash__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "b9a220ab-361f-4863-bb88-4c308ff4dd54",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.__hash__",
  "tags": [
    "entity:method"
  ],
  "text": "def __hash__(self)"
}
```
