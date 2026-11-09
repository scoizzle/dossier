# Fact 40aeb422

Store id: 6512d55b-e377-4eb9-94c9-faaba95faa5d

## Text

```text
def resolve_related_fields(self)
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
- posted_at: `2026-11-09T22:39:44.3227390+00:00`

## Data

```json
{
  "end_line": 804,
  "entity_kind": "method",
  "parent": "ForeignObject",
  "start_line": 782,
  "symbol": "ForeignObject.resolve_related_fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":782,"selector":"L782-L804","symbol":"ForeignObject.resolve_related_fields"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignObject.resolve_related_fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 804,
    "entity_kind": "method",
    "parent": "ForeignObject",
    "start_line": 782,
    "symbol": "ForeignObject.resolve_related_fields"
  },
  "id": "6512d55b-e377-4eb9-94c9-faaba95faa5d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.3227390+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 782,
        "selector": "L782-L804",
        "symbol": "ForeignObject.resolve_related_fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "24e80068-3344-487b-b854-4c5f5213465c",
  "subject_name": "django/db/models/fields/related::ForeignObject.resolve_related_fields",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_related_fields(self)"
}
```
