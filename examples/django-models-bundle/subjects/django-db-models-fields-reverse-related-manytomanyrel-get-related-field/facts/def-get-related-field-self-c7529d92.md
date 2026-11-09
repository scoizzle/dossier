# Fact c7529d92

Store id: 0c828d43-2859-4a69-b8a8-5a6cc3a2748a

## Text

```text
def get_related_field(self)
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
- posted_at: `2026-11-09T22:39:45.3958430+00:00`

## Data

```json
{
  "end_line": 407,
  "entity_kind": "method",
  "parent": "ManyToManyRel",
  "start_line": 394,
  "symbol": "ManyToManyRel.get_related_field"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":394,"selector":"L394-L407","symbol":"ManyToManyRel.get_related_field"}`

## Items

```json
[
  {
    "text": "Return the field in the 'to' object to which this relationship is tied. Provided for symmetry with ManyToOneRel.",
    "locator": {
      "line": 395
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ManyToManyRel.get_related_field](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 407,
    "entity_kind": "method",
    "parent": "ManyToManyRel",
    "start_line": 394,
    "symbol": "ManyToManyRel.get_related_field"
  },
  "id": "0c828d43-2859-4a69-b8a8-5a6cc3a2748a",
  "items": [
    {
      "locator": {
        "line": 395
      },
      "text": "Return the field in the 'to' object to which this relationship is tied. Provided for symmetry with ManyToOneRel."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.3958430+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 394,
        "selector": "L394-L407",
        "symbol": "ManyToManyRel.get_related_field"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "7c15fa9e-d0c4-4a88-89eb-b9e0e12fbbeb",
  "subject_name": "django/db/models/fields/reverse_related::ManyToManyRel.get_related_field",
  "tags": [
    "entity:method"
  ],
  "text": "def get_related_field(self)"
}
```
