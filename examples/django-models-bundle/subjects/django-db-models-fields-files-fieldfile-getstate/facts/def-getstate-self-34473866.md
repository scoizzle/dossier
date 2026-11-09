# Fact 34473866

Store id: a0afc899-3c9e-43c7-bfc1-b7d3faab4c88

## Text

```text
def __getstate__(self)
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
- posted_at: `2026-11-09T23:44:50.6391830+00:00`

## Data

```json
{
  "end_line": 152,
  "entity_kind": "method",
  "parent": "FieldFile",
  "start_line": 141,
  "symbol": "FieldFile.__getstate__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":141,"selector":"L141-L152","symbol":"FieldFile.__getstate__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FieldFile.__getstate__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 152,
    "entity_kind": "method",
    "parent": "FieldFile",
    "start_line": 141,
    "symbol": "FieldFile.__getstate__"
  },
  "id": "a0afc899-3c9e-43c7-bfc1-b7d3faab4c88",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.6391830+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 141,
        "selector": "L141-L152",
        "symbol": "FieldFile.__getstate__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "bad1e5c5-1733-4138-b8a1-29a05684ae71",
  "subject_name": "django/db/models/fields/files::FieldFile.__getstate__",
  "tags": [
    "entity:method"
  ],
  "text": "def __getstate__(self)"
}
```
