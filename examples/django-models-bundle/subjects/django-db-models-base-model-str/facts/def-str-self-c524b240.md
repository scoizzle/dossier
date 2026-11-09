# Fact c524b240

Store id: 6f2adaf0-adbd-4459-ba6a-3f0be3997f05

## Text

```text
def __str__(self)
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
- posted_at: `2026-11-09T22:39:40.3327160+00:00`

## Data

```json
{
  "end_line": 636,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 635,
  "symbol": "Model.__str__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":635,"selector":"L635-L636","symbol":"Model.__str__"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model.__str__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 636,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 635,
    "symbol": "Model.__str__"
  },
  "id": "6f2adaf0-adbd-4459-ba6a-3f0be3997f05",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3327160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 635,
        "selector": "L635-L636",
        "symbol": "Model.__str__"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "d1dfb6ba-0ab4-400a-bad5-d8fc8d697961",
  "subject_name": "django/db/models/base::Model.__str__",
  "tags": [
    "entity:method"
  ],
  "text": "def __str__(self)"
}
```
