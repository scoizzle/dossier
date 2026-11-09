# Fact 83ad4936

Store id: 396dcdfd-1a6e-4ec2-9f18-b2307aa7a5b6

## Text

```text
def __eq__(self, other)
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
- posted_at: `2026-11-09T23:44:52.4733380+00:00`

## Data

```json
{
  "end_line": 155,
  "entity_kind": "method",
  "parent": "ForeignObjectRel",
  "start_line": 152,
  "symbol": "ForeignObjectRel.__eq__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":152,"selector":"L152-L155","symbol":"ForeignObjectRel.__eq__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ForeignObjectRel.__eq__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 155,
    "entity_kind": "method",
    "parent": "ForeignObjectRel",
    "start_line": 152,
    "symbol": "ForeignObjectRel.__eq__"
  },
  "id": "396dcdfd-1a6e-4ec2-9f18-b2307aa7a5b6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.4733380+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 152,
        "selector": "L152-L155",
        "symbol": "ForeignObjectRel.__eq__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "658d3070-1ede-4104-bf91-fc14ae3cae03",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.__eq__",
  "tags": [
    "entity:method"
  ],
  "text": "def __eq__(self, other)"
}
```
