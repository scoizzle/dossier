# Fact fa7e2cac

Store id: 2cd6d75a-98e5-46b8-a733-e953baf70514

## Text

```text
def __reduce__(self)
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
- posted_at: `2026-11-09T22:39:40.3337970+00:00`

## Data

```json
{
  "end_line": 657,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 653,
  "symbol": "Model.__reduce__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":653,"selector":"L653-L657","symbol":"Model.__reduce__"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model.__reduce__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 657,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 653,
    "symbol": "Model.__reduce__"
  },
  "id": "2cd6d75a-98e5-46b8-a733-e953baf70514",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3337970+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 653,
        "selector": "L653-L657",
        "symbol": "Model.__reduce__"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "1d31147b-8a1d-430d-a2dd-1e5291c202fe",
  "subject_name": "django/db/models/base::Model.__reduce__",
  "tags": [
    "entity:method"
  ],
  "text": "def __reduce__(self)"
}
```
