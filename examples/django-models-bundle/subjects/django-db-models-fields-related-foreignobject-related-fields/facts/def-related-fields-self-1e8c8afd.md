# Fact 1e8c8afd

Store id: c732556c-4197-4fcd-a0b6-2f003332073b

## Text

```text
def related_fields(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:58.6824640+00:00`

## Data

```json
{
  "end_line": 808,
  "entity_kind": "method",
  "parent": "ForeignObject",
  "start_line": 806,
  "symbol": "ForeignObject.related_fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":806,"selector":"L806-L808","symbol":"ForeignObject.related_fields"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignObject.related_fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 808,
    "entity_kind": "method",
    "parent": "ForeignObject",
    "start_line": 806,
    "symbol": "ForeignObject.related_fields"
  },
  "id": "c732556c-4197-4fcd-a0b6-2f003332073b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.6824640+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 806,
        "selector": "L806-L808",
        "symbol": "ForeignObject.related_fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "92055ab8-55a4-4dd2-aecb-125aadfd2c87",
  "subject_name": "django/db/models/fields/related::ForeignObject.related_fields",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def related_fields(self)"
}
```
