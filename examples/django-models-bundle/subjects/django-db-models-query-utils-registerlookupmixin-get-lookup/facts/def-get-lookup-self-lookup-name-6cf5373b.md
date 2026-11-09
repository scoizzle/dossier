# Fact 6cf5373b

Store id: 6b8c23f0-c5ec-4587-9f25-64b4889ef597

## Text

```text
def _get_lookup(self, lookup_name)
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
- posted_at: `2026-11-09T22:39:50.1394600+00:00`

## Data

```json
{
  "end_line": 338,
  "entity_kind": "method",
  "parent": "RegisterLookupMixin",
  "start_line": 337,
  "symbol": "RegisterLookupMixin._get_lookup"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":337,"selector":"L337-L338","symbol":"RegisterLookupMixin._get_lookup"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::RegisterLookupMixin._get_lookup](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 338,
    "entity_kind": "method",
    "parent": "RegisterLookupMixin",
    "start_line": 337,
    "symbol": "RegisterLookupMixin._get_lookup"
  },
  "id": "6b8c23f0-c5ec-4587-9f25-64b4889ef597",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.1394600+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 337,
        "selector": "L337-L338",
        "symbol": "RegisterLookupMixin._get_lookup"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "dd738090-bd93-4f60-9e91-5b58df9827f8",
  "subject_name": "django/db/models/query_utils::RegisterLookupMixin._get_lookup",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_lookup(self, lookup_name)"
}
```
