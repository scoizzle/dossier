# Fact 0945ef67

Store id: 793bed85-d404-4c45-bac6-4b0aff1822a1

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
- posted_at: `2026-11-09T23:31:58.8895740+00:00`

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
  "id": "793bed85-d404-4c45-bac6-4b0aff1822a1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.8895740+00:00"
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
  "subject_id": "7e9945e0-1de5-49ec-be86-e013d6efec33",
  "subject_name": "django/db/models/fields/related::ManyToManyField.set_attributes_from_rel",
  "tags": [
    "entity:method"
  ],
  "text": "def set_attributes_from_rel(self)"
}
```
