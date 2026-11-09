# Fact 69eb5627

Store id: ffc5b68e-4a59-4fac-bf4b-5a23b9ac9aaf

## Text

```text
def fetch(self, fetcher, instance)
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
- posted_at: `2026-11-09T22:39:41.9880540+00:00`

## Data

```json
{
  "end_line": 10,
  "entity_kind": "method",
  "parent": "FetchMode",
  "start_line": 9,
  "symbol": "FetchMode.fetch"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fetch_modes.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":9,"selector":"L9-L10","symbol":"FetchMode.fetch"}`

## Referenced by

None.

## Subject

[django/db/models/fetch_modes::FetchMode.fetch](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 10,
    "entity_kind": "method",
    "parent": "FetchMode",
    "start_line": 9,
    "symbol": "FetchMode.fetch"
  },
  "id": "ffc5b68e-4a59-4fac-bf4b-5a23b9ac9aaf",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.9880540+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 9,
        "selector": "L9-L10",
        "symbol": "FetchMode.fetch"
      },
      "rel": "derived_from",
      "target": "django/db/models/fetch_modes.py"
    }
  ],
  "status": "live",
  "subject_id": "26db9ce4-cb28-40ad-a654-529053990187",
  "subject_name": "django/db/models/fetch_modes::FetchMode.fetch",
  "tags": [
    "entity:method"
  ],
  "text": "def fetch(self, fetcher, instance)"
}
```
