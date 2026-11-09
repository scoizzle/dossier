# Fact 5575d66b

Store id: e21132ba-1c39-406d-8101-16fdbc84d75f

## Text

```text
class YearExact(YearLookup, Exact)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:55.0658080+00:00`

## Data

```json
{
  "end_line": 758,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 753,
  "symbol": "YearExact"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":753,"selector":"L753-L758","symbol":"YearExact"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::YearExact](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 758,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 753,
    "symbol": "YearExact"
  },
  "id": "e21132ba-1c39-406d-8101-16fdbc84d75f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.0658080+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 753,
        "selector": "L753-L758",
        "symbol": "YearExact"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "b9465b46-372c-44b1-a1d0-a69fc3f76340",
  "subject_name": "django/db/models/lookups::YearExact",
  "tags": [
    "entity:class"
  ],
  "text": "class YearExact(YearLookup, Exact)"
}
```
