# Fact 8f8b07f3

Store id: 824c0bd0-2dd9-4878-bb84-790e19079bd8

## Text

```text
def open(self, mode="rb")
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
- posted_at: `2026-11-09T23:44:50.6291170+00:00`

## Data

```json
{
  "end_line": 87,
  "entity_kind": "method",
  "parent": "FieldFile",
  "start_line": 81,
  "symbol": "FieldFile.open"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":81,"selector":"L81-L87","symbol":"FieldFile.open"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FieldFile.open](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 87,
    "entity_kind": "method",
    "parent": "FieldFile",
    "start_line": 81,
    "symbol": "FieldFile.open"
  },
  "id": "824c0bd0-2dd9-4878-bb84-790e19079bd8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.6291170+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 81,
        "selector": "L81-L87",
        "symbol": "FieldFile.open"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "7f9b0dd8-7bbc-4fd2-b9db-57b0c5b091c9",
  "subject_name": "django/db/models/fields/files::FieldFile.open",
  "tags": [
    "entity:method"
  ],
  "text": "def open(self, mode=\"rb\")"
}
```
