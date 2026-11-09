# Fact 9d0851ee

Store id: c3b4a8b9-5496-404e-9d68-bd0bf7aa608b

## Text

```text
def __copy__(self)
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
- posted_at: `2026-11-09T23:31:58.6640290+00:00`

## Data

```json
{
  "end_line": 602,
  "entity_kind": "method",
  "parent": "ForeignObject",
  "start_line": 597,
  "symbol": "ForeignObject.__copy__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":597,"selector":"L597-L602","symbol":"ForeignObject.__copy__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignObject.__copy__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 602,
    "entity_kind": "method",
    "parent": "ForeignObject",
    "start_line": 597,
    "symbol": "ForeignObject.__copy__"
  },
  "id": "c3b4a8b9-5496-404e-9d68-bd0bf7aa608b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.6640290+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 597,
        "selector": "L597-L602",
        "symbol": "ForeignObject.__copy__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "832e981a-68e8-4810-89c9-e5aa56534bef",
  "subject_name": "django/db/models/fields/related::ForeignObject.__copy__",
  "tags": [
    "entity:method"
  ],
  "text": "def __copy__(self)"
}
```
