# Fact c21c75a5

Store id: 82da3bb3-c081-4d85-b2f4-271599e35da0

## Text

```text
def _check_clashes(self)
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
- posted_at: `2026-11-09T22:39:44.2591070+00:00`

## Data

```json
{
  "end_line": 369,
  "entity_kind": "method",
  "parent": "RelatedField",
  "start_line": 237,
  "symbol": "RelatedField._check_clashes"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":237,"selector":"L237-L369","symbol":"RelatedField._check_clashes"}`

## Items

```json
[
  {
    "text": "Check accessor and reverse query name clashes.",
    "locator": {
      "line": 238
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related::RelatedField._check_clashes](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 369,
    "entity_kind": "method",
    "parent": "RelatedField",
    "start_line": 237,
    "symbol": "RelatedField._check_clashes"
  },
  "id": "82da3bb3-c081-4d85-b2f4-271599e35da0",
  "items": [
    {
      "locator": {
        "line": 238
      },
      "text": "Check accessor and reverse query name clashes."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.2591070+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 237,
        "selector": "L237-L369",
        "symbol": "RelatedField._check_clashes"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "40e5d8a5-b5fb-4f77-a2e5-00245ab15aa5",
  "subject_name": "django/db/models/fields/related::RelatedField._check_clashes",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_clashes(self)"
}
```
