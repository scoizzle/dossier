# Fact 0945ef67

Store id: c091face-98d9-4943-a29a-04bac4f83fe8

## Text

```text
def set_attributes_from_rel(self)
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
- posted_at: `2026-11-09T22:39:44.5022080+00:00`

## Data

```json
{
  "end_line": 2180,
  "entity_kind": "method",
  "parent": "ManyToManyField",
  "start_line": 2179,
  "symbol": "ManyToManyField.set_attributes_from_rel"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2179,"selector":"L2179-L2180","symbol":"ManyToManyField.set_attributes_from_rel"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ManyToManyField.set_attributes_from_rel](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2180,
    "entity_kind": "method",
    "parent": "ManyToManyField",
    "start_line": 2179,
    "symbol": "ManyToManyField.set_attributes_from_rel"
  },
  "id": "c091face-98d9-4943-a29a-04bac4f83fe8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.5022080+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2179,
        "selector": "L2179-L2180",
        "symbol": "ManyToManyField.set_attributes_from_rel"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "e4482844-513b-4ff6-8f30-a09b2b38894d",
  "subject_name": "django/db/models/fields/related::ManyToManyField.set_attributes_from_rel",
  "tags": [
    "entity:method"
  ],
  "text": "def set_attributes_from_rel(self)"
}
```
