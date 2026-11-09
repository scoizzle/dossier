# Fact b24b1a64

Store id: ef1b52ed-a2f5-4a01-a8f1-5d1336547f9a

## Text

```text
def contribute_to_related_class(self, cls, related)
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
- posted_at: `2026-11-09T22:39:44.3654950+00:00`

## Data

```json
{
  "end_line": 958,
  "entity_kind": "method",
  "parent": "ForeignObject",
  "start_line": 943,
  "symbol": "ForeignObject.contribute_to_related_class"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":943,"selector":"L943-L958","symbol":"ForeignObject.contribute_to_related_class"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignObject.contribute_to_related_class](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 958,
    "entity_kind": "method",
    "parent": "ForeignObject",
    "start_line": 943,
    "symbol": "ForeignObject.contribute_to_related_class"
  },
  "id": "ef1b52ed-a2f5-4a01-a8f1-5d1336547f9a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.3654950+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 943,
        "selector": "L943-L958",
        "symbol": "ForeignObject.contribute_to_related_class"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "9f9f2c41-e73c-474d-a069-f10a7e1db810",
  "subject_name": "django/db/models/fields/related::ForeignObject.contribute_to_related_class",
  "tags": [
    "entity:method"
  ],
  "text": "def contribute_to_related_class(self, cls, related)"
}
```
