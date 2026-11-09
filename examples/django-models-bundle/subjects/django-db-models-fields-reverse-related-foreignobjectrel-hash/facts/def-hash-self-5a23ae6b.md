# Fact 5a23ae6b

Store id: 26f459f3-c487-407e-8eb9-e9f0e9583f08

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
- posted_at: `2026-11-09T23:32:00.2845400+00:00`

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
  "id": "26f459f3-c487-407e-8eb9-e9f0e9583f08",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.2845400+00:00"
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
  "subject_id": "38092c22-0ef2-43cf-9f8e-856f7571b877",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.__hash__",
  "tags": [
    "entity:method"
  ],
  "text": "def __hash__(self)"
}
```
