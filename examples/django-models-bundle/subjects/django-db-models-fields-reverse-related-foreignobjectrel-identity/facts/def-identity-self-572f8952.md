# Fact 572f8952

Store id: 5aa2e2a8-f145-46c7-9739-5bcd32d3b375

## Text

```text
def identity(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:00.2789920+00:00`

## Data

```json
{
  "end_line": 150,
  "entity_kind": "method",
  "parent": "ForeignObjectRel",
  "start_line": 138,
  "symbol": "ForeignObjectRel.identity"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":138,"selector":"L138-L150","symbol":"ForeignObjectRel.identity"}`

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ForeignObjectRel.identity](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 150,
    "entity_kind": "method",
    "parent": "ForeignObjectRel",
    "start_line": 138,
    "symbol": "ForeignObjectRel.identity"
  },
  "id": "5aa2e2a8-f145-46c7-9739-5bcd32d3b375",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.2789920+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 138,
        "selector": "L138-L150",
        "symbol": "ForeignObjectRel.identity"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "5470159c-39bb-4709-8da2-65ab594df5fc",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.identity",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def identity(self)"
}
```
