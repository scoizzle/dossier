# Fact 0b56a5c5

Store id: 0accfc99-207d-47c7-b673-0385559bffaf

## Text

```text
def get_attname_column(self)
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
- posted_at: `2026-11-09T23:31:58.7648090+00:00`

## Data

```json
{
  "end_line": 1264,
  "entity_kind": "method",
  "parent": "ForeignKey",
  "start_line": 1261,
  "symbol": "ForeignKey.get_attname_column"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1261,"selector":"L1261-L1264","symbol":"ForeignKey.get_attname_column"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignKey.get_attname_column](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1264,
    "entity_kind": "method",
    "parent": "ForeignKey",
    "start_line": 1261,
    "symbol": "ForeignKey.get_attname_column"
  },
  "id": "0accfc99-207d-47c7-b673-0385559bffaf",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.7648090+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1261,
        "selector": "L1261-L1264",
        "symbol": "ForeignKey.get_attname_column"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "a8068c2f-a8c0-4ae4-96cf-bd50b13c5538",
  "subject_name": "django/db/models/fields/related::ForeignKey.get_attname_column",
  "tags": [
    "entity:method"
  ],
  "text": "def get_attname_column(self)"
}
```
