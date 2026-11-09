# Fact 3417d610

Store id: 4fa690de-0662-4a1e-9aad-8bb00f10f879

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
- posted_at: `2026-11-09T23:31:57.3565890+00:00`

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
  "id": "4fa690de-0662-4a1e-9aad-8bb00f10f879",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.3565890+00:00"
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
  "subject_id": "bad36673-c91a-44dc-b5dd-adce2dfa6c18",
  "subject_name": "django/db/models/fields/files::FieldFile.path",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def path(self)"
}
```
