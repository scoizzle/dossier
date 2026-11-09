# Fact c6788b69

Store id: 2eb78252-7746-44bc-b42b-60cbd9f16283

## Text

```text
def get_bound_params(self, start, finish)
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
- posted_at: `2026-11-09T22:39:48.2418820+00:00`

## Data

```json
{
  "end_line": 758,
  "entity_kind": "method",
  "parent": "YearExact",
  "start_line": 757,
  "symbol": "YearExact.get_bound_params"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":757,"selector":"L757-L758","symbol":"YearExact.get_bound_params"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::YearExact.get_bound_params](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 758,
    "entity_kind": "method",
    "parent": "YearExact",
    "start_line": 757,
    "symbol": "YearExact.get_bound_params"
  },
  "id": "2eb78252-7746-44bc-b42b-60cbd9f16283",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.2418820+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 757,
        "selector": "L757-L758",
        "symbol": "YearExact.get_bound_params"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "b95fe704-5e51-46d4-8010-d3a6f01aefd5",
  "subject_name": "django/db/models/lookups::YearExact.get_bound_params",
  "tags": [
    "entity:method"
  ],
  "text": "def get_bound_params(self, start, finish)"
}
```
