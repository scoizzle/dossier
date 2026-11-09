# Fact e330104b

Store id: c5d6d6e3-d0c1-4344-8609-c0031c002fdc

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
- posted_at: `2026-11-09T22:39:44.4997660+00:00`

## Data

```json
{
  "end_line": 2177,
  "entity_kind": "method",
  "parent": "ManyToManyField",
  "start_line": 2153,
  "symbol": "ManyToManyField.contribute_to_related_class"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2153,"selector":"L2153-L2177","symbol":"ManyToManyField.contribute_to_related_class"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ManyToManyField.contribute_to_related_class](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2177,
    "entity_kind": "method",
    "parent": "ManyToManyField",
    "start_line": 2153,
    "symbol": "ManyToManyField.contribute_to_related_class"
  },
  "id": "c5d6d6e3-d0c1-4344-8609-c0031c002fdc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.4997660+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2153,
        "selector": "L2153-L2177",
        "symbol": "ManyToManyField.contribute_to_related_class"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "ec0da4d5-b101-4971-9595-dff702a1f95e",
  "subject_name": "django/db/models/fields/related::ManyToManyField.contribute_to_related_class",
  "tags": [
    "entity:method"
  ],
  "text": "def contribute_to_related_class(self, cls, related)"
}
```
