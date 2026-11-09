# Fact 9d0851ee

Store id: 6d549fcb-0370-42ba-81af-5d18f54ba616

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
- posted_at: `2026-11-09T22:39:44.3088790+00:00`

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
  "id": "6d549fcb-0370-42ba-81af-5d18f54ba616",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.3088790+00:00"
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
  "subject_id": "074b3e76-544b-437b-b96a-fb7505545f42",
  "subject_name": "django/db/models/fields/related::ForeignObject.__copy__",
  "tags": [
    "entity:method"
  ],
  "text": "def __copy__(self)"
}
```
