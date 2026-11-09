# Fact cd14ff6a

Store id: c6875dad-5b77-45a5-85bd-ee71313a43ff

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
- posted_at: `2026-11-09T23:31:57.3404620+00:00`

## Data

```json
{
  "end_line": 35,
  "entity_kind": "method",
  "parent": "FieldFile",
  "start_line": 34,
  "symbol": "FieldFile.__hash__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":34,"selector":"L34-L35","symbol":"FieldFile.__hash__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FieldFile.__hash__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 35,
    "entity_kind": "method",
    "parent": "FieldFile",
    "start_line": 34,
    "symbol": "FieldFile.__hash__"
  },
  "id": "c6875dad-5b77-45a5-85bd-ee71313a43ff",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.3404620+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 34,
        "selector": "L34-L35",
        "symbol": "FieldFile.__hash__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "a7b06d6e-703d-4d09-ab64-1cbb3dc2080a",
  "subject_name": "django/db/models/fields/files::FieldFile.__hash__",
  "tags": [
    "entity:method"
  ],
  "text": "def __hash__(self)"
}
```
