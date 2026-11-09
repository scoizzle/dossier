# Fact cf95d339

Store id: 5be32df1-ea67-490a-8584-4f9bd8b26c16

## Text

```text
def contribute_to_class(self, cls, name, private_only=False, **kwargs)
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
- posted_at: `2026-11-09T23:31:58.6187900+00:00`

## Data

```json
{
  "end_line": 407,
  "entity_kind": "method",
  "parent": "RelatedField",
  "start_line": 376,
  "symbol": "RelatedField.contribute_to_class"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":376,"selector":"L376-L407","symbol":"RelatedField.contribute_to_class"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::RelatedField.contribute_to_class](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 407,
    "entity_kind": "method",
    "parent": "RelatedField",
    "start_line": 376,
    "symbol": "RelatedField.contribute_to_class"
  },
  "id": "5be32df1-ea67-490a-8584-4f9bd8b26c16",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.6187900+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 376,
        "selector": "L376-L407",
        "symbol": "RelatedField.contribute_to_class"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "89b6323e-bb80-48c6-bbf7-e31350c5ae61",
  "subject_name": "django/db/models/fields/related::RelatedField.contribute_to_class",
  "tags": [
    "entity:method"
  ],
  "text": "def contribute_to_class(self, cls, name, private_only=False, **kwargs)"
}
```
