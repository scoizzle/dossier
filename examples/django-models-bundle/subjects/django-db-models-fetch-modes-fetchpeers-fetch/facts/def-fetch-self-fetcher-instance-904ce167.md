# Fact 904ce167

Store id: 02c031b2-3103-4ba9-95f5-00cd6232840c

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
- posted_at: `2026-11-09T23:44:49.8160340+00:00`

## Data

```json
{
  "end_line": 40,
  "entity_kind": "method",
  "parent": "FetchPeers",
  "start_line": 31,
  "symbol": "FetchPeers.fetch"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fetch_modes.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":31,"selector":"L31-L40","symbol":"FetchPeers.fetch"}`

## Referenced by

None.

## Subject

[django/db/models/fetch_modes::FetchPeers.fetch](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 40,
    "entity_kind": "method",
    "parent": "FetchPeers",
    "start_line": 31,
    "symbol": "FetchPeers.fetch"
  },
  "id": "02c031b2-3103-4ba9-95f5-00cd6232840c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.8160340+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 31,
        "selector": "L31-L40",
        "symbol": "FetchPeers.fetch"
      },
      "rel": "derived_from",
      "target": "django/db/models/fetch_modes.py"
    }
  ],
  "status": "live",
  "subject_id": "098fcbb0-f1eb-4b11-a1d5-97cd2eb382ba",
  "subject_name": "django/db/models/fetch_modes::FetchPeers.fetch",
  "tags": [
    "entity:method"
  ],
  "text": "def fetch(self, fetcher, instance)"
}
```
