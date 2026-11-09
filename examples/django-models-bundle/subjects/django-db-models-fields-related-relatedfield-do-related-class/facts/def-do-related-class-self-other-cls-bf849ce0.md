# Fact bf849ce0

Store id: 34dedd43-fbb2-481f-9825-f57a560fbfaf

## Text

```text
def do_related_class(self, other, cls)
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
- posted_at: `2026-11-09T22:39:44.2818510+00:00`

## Data

```json
{
  "end_line": 479,
  "entity_kind": "method",
  "parent": "RelatedField",
  "start_line": 477,
  "symbol": "RelatedField.do_related_class"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":477,"selector":"L477-L479","symbol":"RelatedField.do_related_class"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::RelatedField.do_related_class](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 479,
    "entity_kind": "method",
    "parent": "RelatedField",
    "start_line": 477,
    "symbol": "RelatedField.do_related_class"
  },
  "id": "34dedd43-fbb2-481f-9825-f57a560fbfaf",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.2818510+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 477,
        "selector": "L477-L479",
        "symbol": "RelatedField.do_related_class"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "c03219c2-44ac-4fb1-9af2-64efe95d7e07",
  "subject_name": "django/db/models/fields/related::RelatedField.do_related_class",
  "tags": [
    "entity:method"
  ],
  "text": "def do_related_class(self, other, cls)"
}
```
