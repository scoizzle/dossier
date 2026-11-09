# Fact e72e6473

Store id: 802fb216-fdf9-48ab-a12b-5b888d589255

## Text

```text
def __repr__(self)
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
- posted_at: `2026-11-09T23:32:02.9429070+00:00`

## Data

```json
{
  "end_line": 299,
  "entity_kind": "method",
  "parent": "Index",
  "start_line": 285,
  "symbol": "Index.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/indexes.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":285,"selector":"L285-L299","symbol":"Index.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/indexes::Index.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 299,
    "entity_kind": "method",
    "parent": "Index",
    "start_line": 285,
    "symbol": "Index.__repr__"
  },
  "id": "802fb216-fdf9-48ab-a12b-5b888d589255",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.9429070+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 285,
        "selector": "L285-L299",
        "symbol": "Index.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/indexes.py"
    }
  ],
  "status": "live",
  "subject_id": "76ce17a8-ae04-4d09-893f-734a60f9e96e",
  "subject_name": "django/db/models/indexes::Index.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
