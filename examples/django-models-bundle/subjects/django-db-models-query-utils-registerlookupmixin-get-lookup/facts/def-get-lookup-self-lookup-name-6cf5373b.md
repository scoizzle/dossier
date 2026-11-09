# Fact 6cf5373b

Store id: 7b59a963-8d00-40ae-a38e-4a417d69d9cb

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
- posted_at: `2026-11-09T23:32:05.1413010+00:00`

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
  "id": "7b59a963-8d00-40ae-a38e-4a417d69d9cb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.1413010+00:00"
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
  "subject_id": "e5e500c3-ca81-44a5-9c27-9ed0c3d178e7",
  "subject_name": "django/db/models/query_utils::RegisterLookupMixin._get_lookup",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_lookup(self, lookup_name)"
}
```
