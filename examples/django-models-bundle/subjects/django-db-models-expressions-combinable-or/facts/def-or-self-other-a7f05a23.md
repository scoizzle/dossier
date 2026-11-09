# Fact a7f05a23

Store id: f62c691f-6cd4-421a-a11b-f040cbf85484

## Text

```text
def __or__(self, other)
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
- posted_at: `2026-11-09T22:39:41.4813990+00:00`

## Data

```json
{
  "end_line": 128,
  "entity_kind": "method",
  "parent": "Combinable",
  "start_line": 123,
  "symbol": "Combinable.__or__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":123,"selector":"L123-L128","symbol":"Combinable.__or__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Combinable.__or__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 128,
    "entity_kind": "method",
    "parent": "Combinable",
    "start_line": 123,
    "symbol": "Combinable.__or__"
  },
  "id": "f62c691f-6cd4-421a-a11b-f040cbf85484",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.4813990+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 123,
        "selector": "L123-L128",
        "symbol": "Combinable.__or__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "1080e8af-0f68-472f-a274-015938bb2169",
  "subject_name": "django/db/models/expressions::Combinable.__or__",
  "tags": [
    "entity:method"
  ],
  "text": "def __or__(self, other)"
}
```
