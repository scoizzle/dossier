# Fact dfd51039

Store id: 91dcbf50-356c-4788-b173-8dd2d4bce66d

## Text

```text
def __init__( self, verbose_name=None, name=None, upload_to="", storage=None, **kwargs )
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
- posted_at: `2026-11-09T23:44:50.6501240+00:00`

## Data

```json
{
  "end_line": 271,
  "entity_kind": "method",
  "parent": "FileField",
  "start_line": 249,
  "symbol": "FileField.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":249,"selector":"L249-L271","symbol":"FileField.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FileField.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 271,
    "entity_kind": "method",
    "parent": "FileField",
    "start_line": 249,
    "symbol": "FileField.__init__"
  },
  "id": "91dcbf50-356c-4788-b173-8dd2d4bce66d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.6501240+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 249,
        "selector": "L249-L271",
        "symbol": "FileField.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "2e36422d-3fd3-450c-8298-43122980c80a",
  "subject_name": "django/db/models/fields/files::FileField.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, verbose_name=None, name=None, upload_to=\"\", storage=None, **kwargs )"
}
```
