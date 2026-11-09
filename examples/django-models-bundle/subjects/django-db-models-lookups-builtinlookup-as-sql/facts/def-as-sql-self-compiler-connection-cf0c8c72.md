# Fact cf0c8c72

Store id: cb29f331-d87e-408f-8cfe-7cf8c80c5b26

## Text

```text
def as_sql(self, compiler, connection)
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
- posted_at: `2026-11-09T23:32:03.2147670+00:00`

## Data

```json
{
  "end_line": 248,
  "entity_kind": "method",
  "parent": "BuiltinLookup",
  "start_line": 243,
  "symbol": "BuiltinLookup.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":243,"selector":"L243-L248","symbol":"BuiltinLookup.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::BuiltinLookup.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 248,
    "entity_kind": "method",
    "parent": "BuiltinLookup",
    "start_line": 243,
    "symbol": "BuiltinLookup.as_sql"
  },
  "id": "cb29f331-d87e-408f-8cfe-7cf8c80c5b26",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.2147670+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 243,
        "selector": "L243-L248",
        "symbol": "BuiltinLookup.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "f63b7c8c-1fd2-43ad-a787-d5ddb891dce6",
  "subject_name": "django/db/models/lookups::BuiltinLookup.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
