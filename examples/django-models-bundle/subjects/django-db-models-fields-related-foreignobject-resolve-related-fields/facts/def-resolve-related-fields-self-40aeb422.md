# Fact 40aeb422

Store id: bc03b31b-fff9-4af1-8b02-ce79ff49ef3b

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
- posted_at: `2026-11-09T23:31:58.6800960+00:00`

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
  "id": "bc03b31b-fff9-4af1-8b02-ce79ff49ef3b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.6800960+00:00"
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
  "subject_id": "5b6ae9d7-f98d-4afb-93eb-1326ad75d68e",
  "subject_name": "django/db/models/fields/related::ForeignObject.resolve_related_fields",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_related_fields(self)"
}
```
