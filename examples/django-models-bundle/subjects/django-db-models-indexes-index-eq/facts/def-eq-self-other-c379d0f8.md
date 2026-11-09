# Fact c379d0f8

Store id: ffd2f287-d8e8-4d5f-873b-9375d9a6441f

## Text

```text
def __eq__(self, other)
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
- posted_at: `2026-11-09T23:44:54.7079270+00:00`

## Data

```json
{
  "end_line": 304,
  "entity_kind": "method",
  "parent": "Index",
  "start_line": 301,
  "symbol": "Index.__eq__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/indexes.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":301,"selector":"L301-L304","symbol":"Index.__eq__"}`

## Referenced by

None.

## Subject

[django/db/models/indexes::Index.__eq__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 304,
    "entity_kind": "method",
    "parent": "Index",
    "start_line": 301,
    "symbol": "Index.__eq__"
  },
  "id": "ffd2f287-d8e8-4d5f-873b-9375d9a6441f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.7079270+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 301,
        "selector": "L301-L304",
        "symbol": "Index.__eq__"
      },
      "rel": "derived_from",
      "target": "django/db/models/indexes.py"
    }
  ],
  "status": "live",
  "subject_id": "bc6eca29-db50-4940-9b16-e23752087856",
  "subject_name": "django/db/models/indexes::Index.__eq__",
  "tags": [
    "entity:method"
  ],
  "text": "def __eq__(self, other)"
}
```
