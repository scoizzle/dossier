# Fact 3417d610

Store id: 5fe6a99f-8869-438a-a3c3-cf575aaa63ca

## Text

```text
def path(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:43.1997580+00:00`

## Data

```json
{
  "end_line": 67,
  "entity_kind": "method",
  "parent": "FieldFile",
  "start_line": 64,
  "symbol": "FieldFile.path"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":64,"selector":"L64-L67","symbol":"FieldFile.path"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FieldFile.path](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 67,
    "entity_kind": "method",
    "parent": "FieldFile",
    "start_line": 64,
    "symbol": "FieldFile.path"
  },
  "id": "5fe6a99f-8869-438a-a3c3-cf575aaa63ca",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.1997580+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 64,
        "selector": "L64-L67",
        "symbol": "FieldFile.path"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "7afea274-4f6f-4ebb-8229-e32f8085c890",
  "subject_name": "django/db/models/fields/files::FieldFile.path",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def path(self)"
}
```
