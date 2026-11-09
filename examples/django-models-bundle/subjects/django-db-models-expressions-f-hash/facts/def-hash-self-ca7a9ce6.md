# Fact ca7a9ce6

Store id: 7ef317b0-29fa-4a0d-939f-5e6081956f85

## Text

```text
def __hash__(self)
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
- posted_at: `2026-11-09T23:31:55.8384670+00:00`

## Data

```json
{
  "end_line": 940,
  "entity_kind": "method",
  "parent": "F",
  "start_line": 939,
  "symbol": "F.__hash__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":939,"selector":"L939-L940","symbol":"F.__hash__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::F.__hash__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 940,
    "entity_kind": "method",
    "parent": "F",
    "start_line": 939,
    "symbol": "F.__hash__"
  },
  "id": "7ef317b0-29fa-4a0d-939f-5e6081956f85",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8384670+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 939,
        "selector": "L939-L940",
        "symbol": "F.__hash__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "b8c261e2-f5d5-4cb8-a78e-6bdbe0254695",
  "subject_name": "django/db/models/expressions::F.__hash__",
  "tags": [
    "entity:method"
  ],
  "text": "def __hash__(self)"
}
```
