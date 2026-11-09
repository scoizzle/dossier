# Fact 07791708

Store id: 336dfffa-c921-4afa-81ec-d92dad6984f3

## Text

```text
def close(self)
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
- posted_at: `2026-11-09T23:44:50.6377080+00:00`

## Data

```json
{
  "end_line": 139,
  "entity_kind": "method",
  "parent": "FieldFile",
  "start_line": 136,
  "symbol": "FieldFile.close"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":136,"selector":"L136-L139","symbol":"FieldFile.close"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FieldFile.close](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 139,
    "entity_kind": "method",
    "parent": "FieldFile",
    "start_line": 136,
    "symbol": "FieldFile.close"
  },
  "id": "336dfffa-c921-4afa-81ec-d92dad6984f3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.6377080+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 136,
        "selector": "L136-L139",
        "symbol": "FieldFile.close"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "d7d08227-931c-430c-8663-f1aa90b1890b",
  "subject_name": "django/db/models/fields/files::FieldFile.close",
  "tags": [
    "entity:method"
  ],
  "text": "def close(self)"
}
```
