# Fact 6cc47406

Store id: bcba2edf-953f-4375-b5e0-155285374a77

## Text

```text
def related_query_name(self)
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
- posted_at: `2026-11-09T22:39:44.2881920+00:00`

## Data

```json
{
  "end_line": 523,
  "entity_kind": "method",
  "parent": "RelatedField",
  "start_line": 514,
  "symbol": "RelatedField.related_query_name"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":514,"selector":"L514-L523","symbol":"RelatedField.related_query_name"}`

## Items

```json
[
  {
    "text": "Define the name that can be used to identify this related object in a table-spanning query.",
    "locator": {
      "line": 515
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related::RelatedField.related_query_name](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 523,
    "entity_kind": "method",
    "parent": "RelatedField",
    "start_line": 514,
    "symbol": "RelatedField.related_query_name"
  },
  "id": "bcba2edf-953f-4375-b5e0-155285374a77",
  "items": [
    {
      "locator": {
        "line": 515
      },
      "text": "Define the name that can be used to identify this related object in a table-spanning query."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.2881920+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 514,
        "selector": "L514-L523",
        "symbol": "RelatedField.related_query_name"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "e1ed449e-10a1-4f85-bdd9-535ca2b6301b",
  "subject_name": "django/db/models/fields/related::RelatedField.related_query_name",
  "tags": [
    "entity:method"
  ],
  "text": "def related_query_name(self)"
}
```
