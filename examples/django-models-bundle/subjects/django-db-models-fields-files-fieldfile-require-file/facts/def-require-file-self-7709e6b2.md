# Fact 7709e6b2

Store id: 5f6acf03-1b0e-49f3-b368-0bb95935cd2e

## Text

```text
def _require_file(self)
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
- posted_at: `2026-11-09T23:31:57.3469900+00:00`

## Data

```json
{
  "end_line": 48,
  "entity_kind": "method",
  "parent": "FieldFile",
  "start_line": 44,
  "symbol": "FieldFile._require_file"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":44,"selector":"L44-L48","symbol":"FieldFile._require_file"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FieldFile._require_file](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 48,
    "entity_kind": "method",
    "parent": "FieldFile",
    "start_line": 44,
    "symbol": "FieldFile._require_file"
  },
  "id": "5f6acf03-1b0e-49f3-b368-0bb95935cd2e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.3469900+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 44,
        "selector": "L44-L48",
        "symbol": "FieldFile._require_file"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "05789aea-8dcf-405e-b597-b66048a19bab",
  "subject_name": "django/db/models/fields/files::FieldFile._require_file",
  "tags": [
    "entity:method"
  ],
  "text": "def _require_file(self)"
}
```
