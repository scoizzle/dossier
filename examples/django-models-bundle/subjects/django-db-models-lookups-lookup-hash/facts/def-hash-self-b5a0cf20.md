# Fact b5a0cf20

Store id: 428cb93d-2684-4495-ade6-40efe2faacfe

## Text

```text
def __hash__(self)
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
- posted_at: `2026-11-09T23:32:03.1851930+00:00`

## Data

```json
{
  "end_line": 182,
  "entity_kind": "method",
  "parent": "Lookup",
  "start_line": 181,
  "symbol": "Lookup.__hash__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":181,"selector":"L181-L182","symbol":"Lookup.__hash__"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Lookup.__hash__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 182,
    "entity_kind": "method",
    "parent": "Lookup",
    "start_line": 181,
    "symbol": "Lookup.__hash__"
  },
  "id": "428cb93d-2684-4495-ade6-40efe2faacfe",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.1851930+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 181,
        "selector": "L181-L182",
        "symbol": "Lookup.__hash__"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "d1ce9836-cbbf-49ee-b831-7d5d31da1e6b",
  "subject_name": "django/db/models/lookups::Lookup.__hash__",
  "tags": [
    "entity:method"
  ],
  "text": "def __hash__(self)"
}
```
