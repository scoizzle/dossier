# Fact b580d606

Store id: 590f53f0-adca-4df7-9fbb-ead586dcab43

## Text

```text
def select_format(self, compiler, sql, params)
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
- posted_at: `2026-11-09T23:44:54.9069510+00:00`

## Data

```json
{
  "end_line": 204,
  "entity_kind": "method",
  "parent": "Lookup",
  "start_line": 198,
  "symbol": "Lookup.select_format"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":198,"selector":"L198-L204","symbol":"Lookup.select_format"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Lookup.select_format](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 204,
    "entity_kind": "method",
    "parent": "Lookup",
    "start_line": 198,
    "symbol": "Lookup.select_format"
  },
  "id": "590f53f0-adca-4df7-9fbb-ead586dcab43",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.9069510+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 198,
        "selector": "L198-L204",
        "symbol": "Lookup.select_format"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "72e6065c-1afe-4bc8-ae72-4f660ee5b38f",
  "subject_name": "django/db/models/lookups::Lookup.select_format",
  "tags": [
    "entity:method"
  ],
  "text": "def select_format(self, compiler, sql, params)"
}
```
