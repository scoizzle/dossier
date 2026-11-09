# Fact 904ce167

Store id: 264eb0a1-7aef-483c-9ed6-8a52956311c3

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
- posted_at: `2026-11-09T23:31:56.2227610+00:00`

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
  "id": "264eb0a1-7aef-483c-9ed6-8a52956311c3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.2227610+00:00"
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
  "subject_id": "cae2d6d2-4c64-4f75-acef-78c306ff4dbd",
  "subject_name": "django/db/models/fetch_modes::FetchPeers.fetch",
  "tags": [
    "entity:method"
  ],
  "text": "def fetch(self, fetcher, instance)"
}
```
